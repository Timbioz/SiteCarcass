using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Services
{
    public class PostsService : IPostsService
    {
        private readonly IPostsRepository _postsRepository;
        private readonly IUnitOfWork unitOfWork;

        public PostsService(IPostsRepository _postsRepository, IUnitOfWork unitOfWork)
        {
            this._postsRepository = _postsRepository;
            this.unitOfWork = unitOfWork;
        }

        public Posts GetTopic(int id)
        {
            return _postsRepository.GetById(id);
        }

        public IEnumerable<Posts> GetAll()
        {
            return _postsRepository.GetAll();
        }

        public bool CreateTopic(Posts post)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTopic(Posts post)
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
