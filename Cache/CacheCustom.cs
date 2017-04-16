using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace AlgCSharp.Stack
{


    public interface ICache
    {
         bool IsExpired() ;

         int GetIdentifier();

         object GetObject();

    }

    public class Cache : ICache
    {
           private object _cachedObj; 
           private DateTime _expiringDatetime;
           private int _hash;

           public Cache(object obj, int expirationInMinutes, object identifier)
           {    
                _cachedObj = obj;
                _expiringDatetime = DateTime.Now.AddMinutes(expirationInMinutes);
                _hash =  identifier.GetHashCode();

           }

           public bool IsExpired()
           {
               return System.DateTime.Compare(DateTime.Now,_expiringDatetime)>0;
           } 

           public int GetIdentifier()
           {
               return _hash;
           }

            public object GetObject()
            {
                return _cachedObj;
            }

    }

    public class CacheManager 
    {

        private readonly Dictionary<int,object> _cache ;

        public CacheManager()
        {
            _cache = new Dictionary<int,object>();
        }     

        public void AddToCache(ICache obj)
        {
            int identif = obj.GetIdentifier();
            if  (_cache.ContainsKey(identif))
            {
                _cache[identif]=obj;
            }
            else
            {
                _cache.Add(identif,obj);
            }
        }

        public object GetFromCache(int identif)
        {
            if  (_cache.ContainsKey(identif))
            {
               var retObj= (ICache) _cache[identif];
               if (! retObj.IsExpired())
                return retObj.GetObject();
            }
            return null;
        }
    }
}