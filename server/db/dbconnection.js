const mySql = require('mysql');
let db;

if(process.env.DATABASE_URL){

    db = mySql.createConnection(
    process.env.DATABASE_URL
    
//{
    // host: 'localhost',
    // user: process.env.DB_USER,
    // password : process.env.DB_PASSWORD,
    // database: process.env.DB_NAME
//}
);
} else {
    require('dotenv/config');
    db = mySql.createConnection({
        host: 'localhost',
        user: process.env.DB_USER,
        password : process.env.DB_PASSWORD,
        database: process.env.DB_NAME
    });
}

module.exports = db;