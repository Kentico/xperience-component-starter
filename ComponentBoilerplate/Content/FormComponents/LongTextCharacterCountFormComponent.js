window.developmentsite = window.developmentsite || {};
window.developmentsite.registerLongTextCharacterCountFormComponentEvents = function (componentId) {
    var longTextCharacterCountArea = document.querySelector('#'+componentId);
    if(!longTextCharacterCountArea) {
        return;
    }

    var textArea = longTextCharacterCountArea.querySelector('textarea');
    var textCount = longTextCharacterCountArea.querySelector('span.character-count');
    if (!textArea || !textCount) {
        return;
    }

    textCount.innerHTML = textArea.value.length;
    textArea.onkeyup = function (e) {
        textCount.innerHTML = e.target.value.length;
    };
}