﻿using System;

namespace Natasha
{
    public static class DelegateExtension
    {
        public static T Create<T>(this T instance,string content,params string[] usings) where T: Delegate
        {
            return instance = DelegateOperator<T>.Create(content, usings);
        }

        public static Delegate Create(this Type instance, string content, params string[] usings)
        {
            var method = instance.GetMethod("Invoke");
            return FakeMethodOperator
                .New
                .UseMethod(method)
                .Using(usings)
                .StaticMethodContent(content)
                .Complie();
        }
    }
}