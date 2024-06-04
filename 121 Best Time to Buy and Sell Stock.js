/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var maxProfit = 0;
    for (var i = 0; i < prices.length; i++) {
        for (var j = (prices.length - 1); j > i; j--) {
            if (maxProfit < (prices[j] - prices[i])) {
                maxProfit = (prices[j] - prices[i]);
            }
        }
    }

    return maxProfit;
};