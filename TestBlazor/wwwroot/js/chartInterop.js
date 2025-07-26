window.drawBarChart = (canvasId, data) => {
    const ctx = document.getElementById(canvasId).getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: data.labels,
            datasets: [{
                label: 'Wydatki',
                data: data.values,
                backgroundColor: 'rgba(75, 192, 192, 0.7)',
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false
        }
    });
};
