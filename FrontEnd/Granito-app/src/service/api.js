import axios from 'axios';
////prod
// const api = axios.create({
//     baseURL: 'https://studioem.herokuapp.com/'
// });

//dev
const api = axios.create({
    baseURL: 'http://localhost:8080/'
});
export default api;

