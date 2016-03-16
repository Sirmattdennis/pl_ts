var rawData = [
    /* year, sales, expenses */
    ['2004', 1000, 400],
    ['2005', 1170, 460],
    ['2006', 660, 1120],
    ['2007', 1030, 540]
];

var ctx = $("#barChart").get(0).getContext("2d");

var data = {
    labels: ['2004','2005','2006','2007'],
    datasets: [
        {
            label: "Sales",
            fillColor: "rgba(220,220,220,0.5)",
            strokeColor: "rgba(220,220,220,0.8)",
            highlightFill: "rgba(220,220,220,0.75)",
            highlightStroke: "rgba(220,220,220,1)",
            data: [1000, 1170, 660, 1030]
        },
        {
            label: "Expenses",
            fillColor: "rgba(151,187,205,0.5)",
            strokeColor: "rgba(151,187,205,0.8)",
            highlightFill: "rgba(151,187,205,0.75)",
            highlightStroke: "rgba(151,187,205,1)",
            data: [400, 460, 1120, 540]
        }
    ]
};

$(document).ready(function(){
    var newBarChart = new Chart(ctx).Bar(data, {responsive:true});
});