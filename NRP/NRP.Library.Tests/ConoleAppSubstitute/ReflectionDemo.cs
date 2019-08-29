using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NRP.Library.Dto;

namespace NRP.Library.Tests.ConoleAppSubstitute
{
    [TestClass]
    public class ReflectionDemo
    {
        [TestMethod]
        public void ListMethods()
        {
            var person = new Person();

            ListMethods(person.GetType());
            ListStickerAttributes(person.GetType());
        }

        private void ListMethods(Type type)
        {
            foreach (var item in type.GetMethods())
            {
                Console.WriteLine($"{item.Name} : {item.ReturnType}");
            }
        }

        private void ListStickerAttributes(Type type)
        {
            foreach (StickerAttribute item in type.GetCustomAttributes(typeof(StickerAttribute), false))
            {
                Console.WriteLine($"{item.Text}");
            }
        }
    }
}
