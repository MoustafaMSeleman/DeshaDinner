﻿namespace DeshaDinner.Domain.Common.Models;

public abstract class Entity<TId> : IEquatable<Entity<TId>>
{

    public TId Id { get; protected set; }

    public Entity(TId id)
    { this.Id = id; }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> entity && Id.Equals(entity.Id);
    }

    public static bool operator ==(Entity<TId> left, Entity<TId> right)
    {
        return Equals(left, right);
    }

    public static bool operator != (Entity<TId> left, Entity<TId> right) 
    { 
        return !Equals(left, right); 
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public bool Equals(Entity<TId>? other)
    {
        return Equals((object?)other);
    }
}
