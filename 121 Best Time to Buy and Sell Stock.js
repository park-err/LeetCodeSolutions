/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var buy = prices[0];
    var sell = prices[0];
    var profit = 0;

    for (var i = 1; i < prices.length; i++){
        if (prices[i] < buy) {
            buy = prices[i];
            sell = prices[i];
            continue;
        }
        else if (sell < prices[i]) {
            sell = prices[i];
            if (profit < sell - buy) {    
                profit = sell - buy;
            }
        }
    }

    return profit;
};