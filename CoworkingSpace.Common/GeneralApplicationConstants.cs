using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpace.Common
{
    public static class GeneralApplicationConstants
    {

        public class Category
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 50;
        } 
        
        public class Amenity
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
        } 
        
        public class Space
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 100;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;
            
            public const int URLMaxLength = 1000;

        }
    }
}
