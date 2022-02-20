using MyPacktLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPackt.Shared
{
    public class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();
//        List<Person> is read aloud as "list of Person,"
//        for example, "the type of the property named
            //Children is a list of Person instances."


    }
}
