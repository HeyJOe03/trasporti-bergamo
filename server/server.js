const app = require('express')();
const mySql = require('mysql');
const bodyParser = require('body-parser');
const PORT = process.env.PORT || 3000;
const update = require('./routes/update');
const deletePage = require('./routes/delete');
const add = require('./routes/add');
const search = require('./routes/search');

//require('dotenv/config');   //FIXME: probabilmente da rimuovere
const DB = require('./db/dbconnection');

//require('dotenv');

let DB_STATE = true;

DB.connect((e) => {
    if(e) {console.log("error"); data= false; DB_STATE = false}
    else console.log('db connected')
});

app.use(bodyParser.json());
app.use('/update',update);
app.use('/delete',deletePage);
app.use('/add',add);
app.use('/search',search);

app.get('/', (req,res) => {
    //const DBn = process.env.DB_NAME;
    //const DBu = process.env.DB_USER;
    //const DBp = process.env.DB_PASSWORD;
    //const data = {DBn,PORT,DBu,DBp};
    res.send({DB_STATE,"DB_connection":process.env.DATABASE_URL});
});

app.listen(PORT, () => console.log(`> Listening on port: ${PORT}`));