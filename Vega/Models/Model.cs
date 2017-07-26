namespace Vega.Models
{
    public class Model
    {
        public Model()
        {
            this.Make = new Make();
        }

        public int Id {get;set;}
        public string Name {get;set;}
        public Make Make {get;set;}

        //Foreign Key to Make Id. This forein key type should match the primary key type.
        public int MakeId{get;set;}
    }
}