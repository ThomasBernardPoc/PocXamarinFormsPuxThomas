﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PocPuxThomas.Models.Entities.Interfaces;
using SQLite;

namespace PocPuxThomas.Models.Entities
{
    public class CharacterEntity : ICharacterEntity
    {

        [PrimaryKey]
        public long Id { get; set; }
        public long? IdCreator { get; set; }
        public string Image { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }

        public CharacterEntity()
        {
        }

        public CharacterEntity(ICharacterEntity characterEntity)
        {
            Id = characterEntity.Id;
            IdCreator = characterEntity.IdCreator;
            Name = characterEntity.Name;
            Image = characterEntity.Image;
            Species = characterEntity.Species;
            Gender = characterEntity.Gender;
            Origin = characterEntity.Origin;
        }



        public CharacterEntity(long id, long? idCreator, string name, string image, string species, string gender, string origin)
        {
            Id = id;
            IdCreator = idCreator;
            Name = name;
            Image = image;
            Species = species;
            Gender = gender;
            Origin = origin;
        }
    }
}
