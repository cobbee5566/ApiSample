using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ApiSample.Models;

namespace ApiSample.DA.Interfaces
{
    public interface ISampleRepository
    {
        IEnumerable<SampleModel> GetSamples();
    }
}