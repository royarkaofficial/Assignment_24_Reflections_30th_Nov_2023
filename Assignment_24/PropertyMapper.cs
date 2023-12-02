using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24
{
    public static class PropertyMapper
    {
        public static void MapProperties(Source source, Destination destination)
        {
            var sourceProperties = source.GetType().GetProperties();
            var destinationProperties = destination.GetType().GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                var matchingDestinationProperty = destinationProperties.FirstOrDefault(p => p.Name == sourceProperty.Name);

                if (matchingDestinationProperty != null)
                {
                    var value = sourceProperty.GetValue(source);
                    matchingDestinationProperty.SetValue(destination, value);
                }
            }
        }
    }
}
