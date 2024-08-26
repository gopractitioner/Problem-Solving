/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
    let filteredArray = [];
    arr.forEach(
        (number, index) => {
            if (fn(number, index)) filteredArray.push(number)
        }
    )
    return filteredArray;
};