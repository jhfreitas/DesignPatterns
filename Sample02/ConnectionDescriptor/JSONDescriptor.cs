using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sample02
{
    public class JSONDescriptor : IConnectionDescriptor
    {
        public JSONDescriptor()
        {            
        }

        public DescriptorType Type
        {
            get
            {
                return DescriptorType.JSON;
            }
        }

        public String Path
        {
            get; set;
        }

        public object ConnectionParameter
        {
            get
            {
                this.stream = File.Open(this.Path, FileMode.Open);
                this.reader = new StreamReader(this.stream);

                String json = reader.ReadToEnd();

                this.reader.Close();
                this.stream.Close();

                return json;
            }
        }

        //public String Create()
        //{
        //    StreamReader reader = new StreamReader(this.stream);

        //    return reader.ReadToEnd();
        //}

        private Stream stream;
        private StreamReader reader;
    }
}
