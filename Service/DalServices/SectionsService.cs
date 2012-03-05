using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebSite.Data;
using WebSite.Models;
using AutoMapper;

namespace WebSite.Services
{
    public class SectionsService : Disposable, ISectionsService
    {
        private readonly ISectionsRepository sectionsRepository;
        private readonly IUnitOfWork unitOfWork;

        public SectionsService(ISectionsRepository sectionsRepository, IUnitOfWork unitOfWork)
        {
            this.sectionsRepository = sectionsRepository;
            this.unitOfWork = unitOfWork;
        }

        public Sections GetSection(int id)
        {
            return sectionsRepository.GetById(id);
        }

        public IEnumerable<Sections> GetAll()
        {
            return sectionsRepository.GetAll();
        }

        public bool CreateSection(Sections section)
        {
            sectionsRepository.Add(section);
            unitOfWork.Commit();
            if (sectionsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool CreateMapping(object viewModel)
        {
            
            var sect = new Sections();
            Mapper.CreateMap<SectionCreateViewModel, Sections>();
            Mapper.Map((SectionCreateViewModel)viewModel, sect);
            sectionsRepository.Add(sect);
            unitOfWork.Commit();
            if (sectionsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSection(Sections section)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSection(int id)
        {
            sectionsRepository.Delete(e => e.SectionId == id);
            unitOfWork.Commit();
            if (sectionsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteGroup(IEnumerable<int> id)
        {
            foreach (var i in id)
            {
                sectionsRepository.Delete(e => e.SectionId == i);
            }
            unitOfWork.Commit();
            if (sectionsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }

        public override void DisposeCore()
        {
            if (unitOfWork != null)
                unitOfWork.DisposeCore();
            base.DisposeCore();
        }
    }
}
