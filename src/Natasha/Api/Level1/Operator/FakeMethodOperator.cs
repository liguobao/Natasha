﻿using Natasha.CSharp.Builder;
using Natasha.Reverser;
using System.Reflection;

namespace Natasha.CSharp
{
    /// <summary>
    /// 根据现有反射方法伪造一个方法，内容自己定
    /// </summary>
    public class FakeMethodOperator : MethodBuilder<FakeMethodOperator>
    {

        private MethodInfo _method_info;


        
        public FakeMethodOperator()
        {

            Link = this;

        }



        public override void Init()
        {

            ClassOptions(item => item
            .Modifier(Reverser.Model.ModifierFlags.Static)
            .Class()
            .UseRandomName()
            .HiddenNamespace()
            .Access(Reverser.Model.AccessFlags.Public)
            );

        }







        /// <summary>
        /// 填装反射方法
        /// </summary>
        /// <param name="reflectMethodInfo">反射方法</param>
        /// <returns></returns>
        public FakeMethodOperator UseMethod(MethodInfo reflectMethodInfo)
        {

            _method_info = reflectMethodInfo;
            return this;

        }
        public FakeMethodOperator UseMethod<T>(string methodName)
        {

            _method_info = typeof(T).GetMethod(methodName);
            return this;

        }



        /// <summary>
        /// 指定方法内容
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private FakeMethodOperator MethodCopy()
        {

            if (NameScript == default)
            {

                Name(_method_info);

            }

            return Access(_method_info)
            .Param(_method_info)
            .Return(_method_info);

        }


        //public new FakeMethodOperator Body(string body)
        //{
        //    return Methodbody(body);
        //}
        public FakeMethodOperator MethodBody(string body)
        {

            MethodCopy();
            ModifierAppend(AsyncReverser.GetAsync(_method_info));
            return Body(body);
            
        }


        /// <summary>
        /// 指定方法内容
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public FakeMethodOperator StaticMethodBody(string body)
        {

            MethodCopy();
            Modifier(Reverser.Model.ModifierFlags.Static);
            ModifierAppend(AsyncReverser.GetAsync(_method_info));
            return Body(body);

        }

    }

}
