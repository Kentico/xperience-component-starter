function registerWidgetEvents() {
    var widgetButtons = document.querySelectorAll('.text-area-widget button.btn-display-content');
    if (!widgetButtons) {
        return;
    }
    widgetButtons.forEach(function (button) {
        button.onclick = function () {
            button.parentElement.querySelector('div.content');
            var widgetContent = button.parentElement.querySelector('div.content').innerText;
            alert(widgetContent || "Widget content is empty");
        };
    });
        
}

if (document.readyState === "widgetLoaded") {
    // Calls the function during the 'DOMContentLoaded' event, after the HTML document has been completely loaded
    document.addEventListener("DOMContentLoaded", registerWidgetEvents);
} else {
    // Calls the function directly in cases where the widget is rendered dynamically after 'DOMContentLoaded' has occurred
    registerWidgetEvents();
}