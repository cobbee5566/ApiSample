using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ApiSample.BL.Interfaces;
using ApiSample.DA.Interfaces;
using ApiSample.DA.Repositories;
using ApiSample.Models;

namespace ApiSample.BL.Services
{
    public class SampleService:ISampleService
    {
        public ISampleRepository SampleRepository { get; set; }

        /// <summary>
        /// 建構子，尚未套用IoC，暫時直接初始化
        /// </summary>
        public SampleService():this(new SampleRepository())
        { 
        }

        public SampleService(ISampleRepository sampleRepository)
        {
            this.SampleRepository = sampleRepository;
        }

        public IEnumerable<SampleModel> GetSamples()
        {
            return this.SampleRepository.GetSamples();
        }
    }
}