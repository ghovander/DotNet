using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vega.Models;

namespace Vega.Controllers.Resources
{
    public class MakeResource
    {
        public MakeResource()
        {
            this.Models = new Collection<ModelResource>();
        }

        public int Id {get;set;}
        public string Name {get;set;}
        public ICollection<ModelResource> Models {get;set;} 
    }
}