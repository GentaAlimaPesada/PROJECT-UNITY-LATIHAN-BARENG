using System.Collections;
using System;
using UnityEngine;
using System.Collections.Generic;

public class ServiceLocator
{
    private static Dictionary<Type, object> services = new Dictionary<Type, object>();

    public static void RegisterService<T>(T service)
    {
        Type serviceType = typeof(T);
        if (!services.ContainsKey(serviceType))
        {
            services.Add(serviceType, service);
        }
        else
        {
            services[serviceType] = service;
        }
    }

    public static T GetService<T>()
    {
        Type serviceType = typeof(T);
        if (services.ContainsKey(serviceType))
        {
            return (T)services[serviceType];
        }
        else
        {
            Debug.LogError($"Service of type {serviceType} not registered.");
            return default(T);
        }
    }
}
