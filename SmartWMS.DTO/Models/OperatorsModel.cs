using System;
using System.Collections.Generic;

namespace SmartWMS.DTO.Models
{
    public partial class OperatorsModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int? OperatorTypeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

        public string LastName { get; set; }

        public int? SuperiorId { get; set; }

        public int? FunctionId { get; set; }

        public int? QualificationId { get; set; }

        public bool Active { get; set; }

        public int? UserId { get; set; }

        public int? PriceListId { get; set; }
        public DateTime? EditDate { get; set; }

        public string EditUserCode { get; set; }

        public string CreateUserCode { get; set; }

        public DateTime? CreateDate { get; set; }

        #endregion

    }
}
