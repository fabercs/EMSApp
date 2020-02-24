﻿using System;

namespace EMSApp.Core.Interfaces
{
    public interface IEntity
    {
        object Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? ModifedOn { get; set; }
        Guid? CreatedBy { get; set; }
        Guid? ModifiedBy { get; set; }
        byte[] Version { get; set; }
    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }
}
