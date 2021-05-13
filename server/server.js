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

DB.connect((e) => {
    if(e) {console.log("error"); data= false;}
    else console.log('db connected')
});

app.use(bodyParser.json());
app.use('/update',update);
app.use('/delete',deletePage);
app.use('/add',add);
app.use('/search',search);

app.get('/', (req,res) => {
    res.send('The server is working');
});

app.listen(PORT, () => console.log(`> Listening on port: ${PORT}`));