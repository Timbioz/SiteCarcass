using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Services
{
    public class TopicsService : ITopicsService
    {
        private readonly ITopicsRepository topicsRepository;
        private readonly IUnitOfWork unitOfWork;

        public TopicsService(ITopicsRepository topicsRepository, IUnitOfWork unitOfWork)
        {
            this.topicsRepository = topicsRepository;
            this.unitOfWork = unitOfWork;
        }

        public Topics GetTopic(int id)
        {
            return topicsRepository.GetById(id);
        }

        public IEnumerable<Topics> GetAll()
        {
            return topicsRepository.GetAll();
        }

        public bool CreateTopic(Topics topic)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTopic(Topics topic)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTopic(int id)
        {
            throw new NotImplementedException();
        }

        public void DisposeCore()
        {
            throw new NotImplementedException();
        }
    }
}
