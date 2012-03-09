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
        
        //?+Total Count
        /// <summary>
        /// Возвращает количество всех разделов в базе данных
        /// </summary>
        /// <returns></returns>
        public int TotalCount()
        {
            return sectionsRepository.Count();
        }
        
        //?+Get Section
        public Sections GetSection(int id)
        {
            return sectionsRepository.GetById(id);
        }
        //?+Get All
        public IEnumerable<Sections> GetAll()
        {
            return sectionsRepository.GetAll();
        }
        //?+Create Section
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
        //?+Create Mapping
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

        

        //?+Update Section
        public bool UpdateSection(Sections section)
        {
            sectionsRepository.Update(section);
            unitOfWork.Commit();
            if (sectionsRepository != null && unitOfWork != null)
            {
                return true;
            }
            return false;
        }
        //?+Delete Section
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
        //?+Delete Group
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
        //?DisposeCore
        //public override void DisposeCore()
        //{
        //    if (unitOfWork != null)
        //        unitOfWork.DisposeCore();
        //    base.DisposeCore();
        //}
    }
}
