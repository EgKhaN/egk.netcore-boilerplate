﻿using egk.netcore_boilerplate.api.Data.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Data.Entities
{
    public abstract class AuditableEntity<T> : BaseEntity<T> , IAuditableEntity
    {
        private DateTime? createdDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; } 
        
        [DataType(DataType.DateTime)]
        public DateTime? DeletedDate { get; set; }

        private string _createdBy { get; set; }
        public string CreatedBy
        {
            get { return _createdBy ?? "EgK"; }
            set { _createdBy = value; }
        }

        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
