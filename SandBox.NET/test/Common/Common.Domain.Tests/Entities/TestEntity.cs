﻿using Common.Domain.Entities.Abstractions;
using Common.Domain.ValueObjects;

namespace Common.Domain.Tests.Entities
{
    /// <inheritdoc />
    public class TestEntity : IEntity<TestEntity>
    {
        /// <summary>Initializes a new instance of the <see cref="Common.Domain.Tests.Entities.TestEntity"/> class.</summary>
        /// <param name="id"><see cref="Id{T}"/></param>
        public TestEntity(Id<TestEntity> id)
        {
            Id = id;
        }

        /// <inheritdoc />
        public Id<TestEntity> Id { get; }
    }
}