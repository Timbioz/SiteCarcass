using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using WebSite.Data;
using WebSite.Models;

namespace WebSite.Services
{
    public class CategoryService : Disposable, ICategoryService
    {
        private readonly ICategoryRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public int TotalCount()
        {
            return repository.Count();
        }

        public Category GetCategory(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return repository.GetAll();
        }

        public bool CreateCategory(Category entity)
        {
            repository.Add(entity);
            unitOfWork.Commit();
            if (repository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool CreateMapping(object viewModel)
        {
            var cats = new Category();
            Mapper.CreateMap<CreateCategoryViewModel, Category>();
            Mapper.Map((CreateCategoryViewModel)viewModel, cats);
            repository.Add(cats);
            unitOfWork.Commit();
            if (repository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateCategory(Category entity)
        {
            repository.Update(entity);
            unitOfWork.Commit();
            if (repository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteCategory(int id)
        {
            repository.Delete(e => e.CategoryId == id);
            unitOfWork.Commit();
            if (repository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGroup(IEnumerable<int> id)
        {
            foreach (var i in id)
            {
                repository.Delete(e => e.CategoryId == i);
            }
            unitOfWork.Commit();
            if (repository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }
    }
}
