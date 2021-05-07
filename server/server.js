const app = require('express')();
const mySql = require('mysql');
const bodyParser = require('body-parser');
const PORT = process.env.PORT || 3000;
const update = require('./routes/update');
const deletePage = require('./routes/delete');
const add = require('./routes/add');
const search = require('./routes/search');

require('dotenv/config');
const DB = require('./db/dbconnection');

DB.connect((e) => {
    if(e) console.log("error"); 
    else console.log('db connected')
});

//DB.query('INSERT INTO veicoli (ID,marca,stato,disponibilita,posti,latitudine,longitudine,costoMinuto,costoOra,costoGiorno) VALUES (40,"punto",0,0,2,6.57348,5.57349,3.1,12,30.1);', (e) => {if (e) console.log("error")});

app.use(bodyParser.json());
app.use('/update',update);
app.use('/delete',deletePage);
app.use('/add',add);
app.use('/search',search);

app.get('/', (req,res) => {res.send('hello world')});

app.listen(PORT, () => console.log(`> Listening on port: ${PORT}`));