// kendisine verilecek sayının faktöriyelini geri döndüren bir func. hazırlıyoruz.

export const calculateFactorial = num =>{
    if (num == 0 || num == 1) return 1;
    // let result = 0;
    for (let i = num - 1; i >= 1; i--) {
        num = num * i;
    };
    // for (let i = 0; i < num; i++) {
    //    result = num * calculateFactorial(num-1);
    // }
    // return result;
    return num;
};

const display = () => {
    console.log("Merhaba");
}

export {display};
export default calculateFactorial;
