window.developmentsite = window.developmentsite || {};
window.developmentsite.registerTextAreaWidgetEvents = function (componentId) {
    var button = document.querySelector('#'+componentId);
    if (!button) {
        return;
    }

    button.onclick = function () {
        button.parentElement.querySelector('div.content');
        var widgetContent = button.parentElement.querySelector('div.content').innerText;
        alert(widgetContent || "Widget content is empty");
    };
};