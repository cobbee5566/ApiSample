using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ApiSample.DA.Interfaces;
using ApiSample.Models;

namespace ApiSample.DA.Repositories
{
    public class SampleRepository:ISampleRepository
    {
        public IEnumerable<SampleModel> GetSamples()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new SampleModel()
                {
                    Id = i,
                    Data = string.Format("Data - {0}", i),
                    CreatedAt = DateTime.Now
                };
            }
        }
    }
}