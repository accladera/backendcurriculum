using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Command.CurriculumCommand
{
    public class StoreCurriculumCommand : IRequest<int>
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Cellphone { get; set; }

        public string Phone { get; set; }

        public string Nationality { get; set; }

        public int TypeDocumentId { get; set; }

        public int DocumentNumber { get; set; }

        public DateTime Birthday { get; set; }

        public int GenderId { get; set; }

        public int MaritalStatusId { get; set; }

        public int ClientId { get; set; }

        public void SetId(int id) => Id = id;



    }
}
