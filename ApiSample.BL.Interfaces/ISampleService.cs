using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ApiSample.Models;

namespace ApiSample.BL.Interfaces
{
    public interface ISampleService
    {
        IEnumerable<SampleModel> GetSamples();
    }
}