namespace PG.Test
{
    /* 
    Unit Testing with the 
    Arrange, Act, Assert Pattern

    Arrange
    - Set up the test
    Act
    - Invoke the method we want to test
    Assert
    - Verify that the action of the tested
        method behaved as expected
    */

    using NUnit.Framework;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;
    using System.Collections.Generic;
    using PG.Cross.IoC;
    using PG.Core.Models.UserEntities;
    using PG.Repo;
    using PG.Services;

    [TestFixture]
    public class Tests
    {
        private ServiceProvider serviceProvider { get; set; }

        [SetUp]
        public void Setup()
        {
            IServiceCollection services = new ServiceCollection();
            NativeInjectorBootStrapper.RegisterServices(services: services);
            serviceProvider = services.BuildServiceProvider();
        }

        public PGContext GetDbContext()
        {
            PGContext context = serviceProvider.GetService<PGContext>();

            if (context is not null)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            return context;
        }

        private void Seed(PGContext context)
        {
            List<UserEntity> userLst = new()
            {
                new UserEntity(id: "0000", name: "TEST"),
                new UserEntity(id: "0001", name: "TEST"),
                new UserEntity(id: "0002", name: "TEST")
            };

            context.Users.AddRange(entities: userLst);
            context.SaveChanges();
        }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void TestGetingtData()
        {
            // ARRANGE
            PGContext context = GetDbContext();
            Seed(context: context);

            // ASSERT
            Assert.AreEqual(expected: 3, actual: context.Users.Count());
        }

        [Test]
        public void AddUser_User_UserIsAdd()
        {
            // Method AddUser_User_UserIsAdd()
            // - AddUser: Name of the method being tested
            // - User: Scenario (state) under which the method is being tested
            // - UserIsAdd: Expected behavior when the scenario is invoked

            // ARRANGE
            // - Set up the context, instantiate the repository, create an user to add
            // ACT
            // - Call the AddUser method on the repository
            // ASSERT
            // - Check if user was added

            // ARRANGE
            PGContext context = GetDbContext();
            UserEntity user = new UserEntity(id: "0000", name: "TEST");
            
            // ACT
            EntityEntry<UserEntity> entry = context.Users.Add(entity: user);
            int numberOfStateEntries = context.SaveChanges();
            // var entryEntity = context.Entry(entity: user);
            // entryEntity.State = EntityState.Added;

            // ASSERT
            Assert.AreEqual(expected: 1, actual: context.Users.Count());
        }

        [Test]
        public void Test_Admin_Load()
        {
            var service = new AdminServices();
            service.Admin_Load();

             // ASSERT
            Assert.Pass();
        }

        
    }
}