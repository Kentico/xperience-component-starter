/// <reference path="../../../../types/global.d.ts" />

import "./style.less";

window.kentico.pageBuilder.registerInlineEditor("MyCompany.InlineEditor.ImageUrl", {
    init(options) {
        const editor = options.editor;
        const input = editor.querySelector("input");
        const button = editor.querySelector(".cmp-image-url-apply");

        if (button !== null && input !== null) {
            button.addEventListener("click", (e) => {
                e.preventDefault();
                const event = new CustomEvent("updateProperty", {
                    detail: {
                        value: input.value,
                        name: options.propertyName
                    }
                });

                editor.dispatchEvent(event);
            });
        }
    },
});