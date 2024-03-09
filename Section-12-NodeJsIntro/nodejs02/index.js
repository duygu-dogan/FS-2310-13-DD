//http işleri için http adındaki node modül kullanılır.
const http = require('http');
const server = http.createServer((request, response)=> {
    response.write('<h1>Hello NodeJs Server!</h1>');
    response.end();
});

server.listen(3000);
console.log('Server 3000 nolu porttan ayağa kalktı.');
console.log('http://localhost:3000 yazarak ulaşabilirsiniz.');