﻿using FluentAssertions;
using goodfood_provider.Entities;
using goodfood_provider.Models;
using goodfood_provider.Repositories;
using goodfood_provider.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace goodfood_provider_test
{
    public class UpdateProvider
    {

        private readonly ProviderContext context;



        public UpdateProvider()
        {
            context = new ProviderContext(new DbContextOptionsBuilder<ProviderContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options);
        }


        [Fact]
        public async void ShouldUpdateAProvider()
        {
            //arrange
            var providerOLD = new Provider()
            {
                Id = 1,
                Name = "Nom old",
                Address = "adresse",
                City = "ville",
                Cp = "code postal",
                Informations = "informations",
                ProviderImage = null,
                IsOpen = false,

            };

            var providerNEW = new Provider()
            {
                Id = 1,
                Name = "Nom new",
                Address = "adresse",
                City = "ville",
                Cp = "code postal",
                Informations = "informations",
                ProviderImage = null,
                IsOpen = false,

            };

            var providerModel = new ProviderModel()
            {
                Id = 1,
                Name = "Nom new",
                Address = "adresse",
                City = "ville",
                Cp = "code postal",
                Informations = "informations",
                ProviderImage = null,
                IsOpen = false,

            };

            //act
            ProviderRepository providerRepository = new ProviderRepository(context);
            await context.Providers.AddAsync(providerOLD);
            await context.SaveChangesAsync();

            await providerRepository.UpdateProvider(providerModel);

            var result = await context.Providers.FirstOrDefaultAsync(p => p.Id == providerOLD.Id);

            //assert
            result.Name.Should().Be(providerNEW.Name);


        }
    }
}