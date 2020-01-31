using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;
using Dapper;

namespace Keepr.Repositories
{
    public class KeepRepository
    {
        private readonly IDbConnection _db;

        public KeepRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Keep> Get()
        {
            string sql = "SELECT * FROM Keeps";
            //Dapper will call to database and all objects return will be cast to <Keep>
            return _db.Query<Keep>(sql);
        }

        internal void Create(Keep KeepData)
        {
            string sql = @"
            INSERT INTO Keeps
            (name, description, userId, img, isPrivate)
            VALUES
            (@Name, @Description, @UserId, @Img, @IsPrivate)
            ";
            _db.Execute(sql, KeepData);
        }
    }
}