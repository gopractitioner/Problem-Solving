/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function (nums, fn, init) {
    var result = init;
    nums.forEach(
        number => {
            result = fn(result, number)
        }
    )
    return result;
};