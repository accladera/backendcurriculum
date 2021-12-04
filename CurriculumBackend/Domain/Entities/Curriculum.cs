using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using Core.AggreateRoot;
using Core.Rules.PhoneNumber;
using System.Linq;

namespace Domain.Entities
{
    public class Curriculum : BaseModel, IAggregateRoot
    {

        public override int Id { get; protected set; }


        public string Name { get; set; }

       
        public string LastName { get; set; }

       
        public string Cellphone { get; set; }

       
        public string? Phone { get; set; }

      
        public string? Nationality { get; set; }

   
        public int TypeDocumentId { get; set; }

        
        public int DocumentNumber { get; set; }

        
        public DateTime? Birthday { get; set; }

        
        public int GenderId { get; set; }

    
        public int? MaritalStatusId { get; set; }

        public int ClientId { get; set; }

        public Curriculum(string name, string lastName, string cellphone, string phone, string nationality, int typeDocumentId, int documentNumber, DateTime birthday, int genderId, int maritalStatusId, int clientId) : this()
        {
          
            Name = name;
            LastName = lastName;
            Cellphone = new PhoneNumberValue(cellphone) ;
            Phone = phone;
            Nationality = nationality;
            TypeDocumentId = typeDocumentId;
            DocumentNumber =documentNumber;
            Birthday = birthday;
            GenderId = genderId;
            MaritalStatusId = maritalStatusId;
            ClientId = clientId;
        }

        public Curriculum(int id,string name, string lastName, string cellphone,int userId) : this()
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Cellphone = new PhoneNumberValue(cellphone);
            ClientId = userId;


        }



        protected Curriculum()
        {
            CurAbilities = new List<CurriculumAbilities>();
            CurAdionalInformations = new List<CurriculumAditionalInformation>();
            CurExperiences = new List<CurriculumExperience>();
            CurGenerals = new List<CurriculumGeneral>();
            CurIdiomes = new List<CurriculumIdiom>();
            CurReferences = new List<CurriculumReference>();
            CurStudies = new List<CurriculumStudies>();
        }

     

        public List<CurriculumAbilities> CurAbilities { get; set; }



        public List<CurriculumAditionalInformation> CurAdionalInformations { get; set; }
       


        public List<CurriculumExperience> CurExperiences { get; set; }
       



        public List<CurriculumGeneral> CurGenerals { get; set; }
       


        public List<CurriculumIdiom> CurIdiomes { get; set; }
    



        public List<CurriculumReference> CurReferences { get; set; }




        public List<CurriculumStudies> CurStudies { get; set; }




        // Reglas de negocio

        public void UpdateCurriculum(string name, string lastName, string cellphone, string phone, string nationality, int typeDocumentId, int documentNumber, DateTime birthday, int genderId, int maritalStatusId, int clientId)
        {
            Name = name;
            LastName = lastName;
            Cellphone = new PhoneNumberValue(cellphone);
            Phone = phone;
            Nationality = nationality;
            TypeDocumentId = typeDocumentId;
            DocumentNumber = documentNumber;
            Birthday = birthday;
            GenderId = genderId;
            MaritalStatusId = maritalStatusId;
            ClientId = clientId;
        }

        public void AddCurriculumAbilities(string ability, int experencesYear, int? IdAbilities = null)
        {
            if (IdAbilities.HasValue)
            {
                foreach (var curri in CurAbilities)
                {
                   if(curri.Id == IdAbilities.Value)
                    {
                        curri.UpdateAbilities(ability, experencesYear);
                    } 
                }
            }
            else
            {
                var response = new CurriculumAbilities(ability, experencesYear);
                CurAbilities.Add(response);
            }
        }

       


        public void AddCurriculumAditionInformation(string information, int? IdAdicionaltInformation = null)
        {
            if (IdAdicionaltInformation.HasValue)
            {
                foreach (var curri in CurAdionalInformations)
                {
                    if (curri.Id == IdAdicionaltInformation.Value)
                    {
                        curri.UpdateInformation(information);
                    }
                }
            }
            else
            {
                var response = new CurriculumAditionalInformation(information);
                CurAdionalInformations.Add(response);
            }

           
        }

        public void AddCurriculumAExperence(string position, int areaWorkId, string company, int countryId, string ubication, bool currentlyHasThePosition,
             DateTime dateInit, DateTime dateFinish, int experienceYears, int dependents, string description, int? IdExperenceCurri = null)
        {
            if (IdExperenceCurri.HasValue)
            {
                foreach (var curri in CurExperiences)
                {
                    if (curri.Id == IdExperenceCurri.Value)
                    {
                        curri.UpdateExperence(position, areaWorkId, company, countryId, ubication, currentlyHasThePosition, dateInit,
                                                dateFinish, experienceYears, dependents, description);
                    }
                }
            }
            else
            {
                var response = new CurriculumExperience(position, areaWorkId, company, countryId, ubication, currentlyHasThePosition, dateInit,
                dateFinish, experienceYears, dependents, description);
                CurExperiences.Add(response);
            }

            
        }

        public void AddCurriculumAGeneral(string title, int categoryId, int contractTypeId, string salary, int countryReferenceId, string presentation
            , int? IdCurriGeneral = null)
        {

            if (IdCurriGeneral.HasValue)
            {
                foreach (var curri in CurGenerals)
                {
                    if (curri.Id == IdCurriGeneral.Value)
                    {
                        curri.UpdateGeneral(title, categoryId, contractTypeId, salary, countryReferenceId, presentation);
                    }
                }
            }
            else
            {
                var response = new CurriculumGeneral(title, categoryId, contractTypeId, salary, countryReferenceId, presentation);
                CurGenerals.Add(response);
            }

            
        }

        public void AddCurriculumIdom(int idiomId, int levelWrite, int levelOral, int levelRead, int? IdCurriIdom = null)
        {
            if (IdCurriIdom.HasValue)
            {
                foreach (var curri in CurIdiomes)
                {
                    if (curri.Id == IdCurriIdom.Value)
                    {
                        curri.UpdateIdoms(idiomId, levelWrite, levelOral, levelRead);
                    }
                }
            }
            else
            {
                var response = new CurriculumIdiom(idiomId, levelWrite, levelOral, levelRead);
                CurIdiomes.Add(response);
            }
           
        }

        public void AddCurriculumReference(string name, string company, string cellphone, int? IdReference = null)
        {
            if (IdReference.HasValue)
            {
                foreach (var curri in CurReferences)
                {
                    if (curri.Id == IdReference.Value)
                    {
                        curri.UpdateReference(name, company, cellphone);
                    }
                }
            }
            else
            {
                var response = new CurriculumReference(name, company, cellphone);
                CurReferences.Add(response);
            }
        }

        public void AddCurriculumStudies(string school, int levelStudyIdSchool, int countryIdSchool, DateTime init, DateTime finish, bool currentlyStudyingHere
            , string university, string semester, int levelStudyIdUniversity, int countryIdUniversity, int? IdStudies = null)
        {
            if (IdStudies.HasValue)
            {
                foreach (var curri in CurStudies)
                {
                    if (curri.Id == IdStudies.Value)
                    {
                        curri.UpdateStudies(school, levelStudyIdSchool, countryIdSchool, init, finish, currentlyStudyingHere, university, semester, levelStudyIdUniversity, countryIdUniversity);
                    }
                }
            }
            else
            {
                var response = new CurriculumStudies(school, levelStudyIdSchool, countryIdSchool, init, finish, currentlyStudyingHere, university, semester, levelStudyIdUniversity, countryIdUniversity);
                CurStudies.Add(response);
            }

            
        }

















    }
}
