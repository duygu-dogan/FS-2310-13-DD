export const getTotal = (...numbers) => {
    const numArr = [...numbers];
    let total = 0;
    for (let i = 0; i < numArr.length; i++) {
        total += numArr[i];        
    };
    return total;
};


// export { getTotal };