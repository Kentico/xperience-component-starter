import { debounce } from "debounce";

import "./style.less";
import { ImageUrlOptions } from "../../../../types/company";

window.Company = window.Company || {} as any;

const urlPattern = new RegExp('^(https?:\\/\\/)?' + // protocol
    '((([a-z\\d]([a-z\\d-]*[a-z\\d])*)\\.)+[a-z]{2,}|' + // domain name
    '((\\d{1,3}\\.){3}\\d{1,3}))' + // OR ip (v4) address
    '(\\:\\d+)?(\\/[-a-z\\d%_.~+]*)*' + // port and path
    '(\\?[;&a-z\\d%_.~+=-]*)?' + // query string
    '(\\#[-a-z\\d_]*)?$', 'i'); // fragment locator

const isUrlImage = (url: string): Promise<boolean> => {
    return new Promise((resolve, reject) => {
        if (!urlPattern.test(url)) {
            reject("Invalid URL.");
            return;
        }

        const xhttp = new XMLHttpRequest();
        xhttp.open('HEAD', url);
        xhttp.onload = function () {
            if (this.status === 200) {
                if (this.getResponseHeader("Content-Type")!.indexOf("image") !== -1) {
                    resolve(true);
                } else {
                    resolve(false);
                }
            } else {
                reject("The provided URL does not represent an image.");
            }
        };
        xhttp.onerror = () => {
            reject("Request failed.");
        }

        xhttp.send();
    });
}

const init = (options: ImageUrlOptions) => {
    const controlInstance = document.querySelector(`div[data-control-instance-id='${options.identifier}']`);
    
    const imageUrlControl = controlInstance && controlInstance.querySelector(`.${options.controlClassName}`);
    const validationMessage = controlInstance && controlInstance.querySelector(`.${options.validationClassName}`);
    const imagePreview = controlInstance && controlInstance.querySelector<HTMLImageElement>(`.${options.imagePreviewClassName}`);

    if (!controlInstance || !imageUrlControl || !validationMessage || !imagePreview) {
        return;
    }

    const { debounce, isUrlImage } = window.Company;

    const setPreviewImage = (imageUrl: string | null, errorMessage: string | null = null) => {
        if (imageUrl) {
            imagePreview.src = imageUrl;
            validationMessage.textContent = "";
        } else {
            imagePreview.src = options.placeholderImageUri;
            validationMessage.textContent = errorMessage;
        }
    };

    imageUrlControl.addEventListener("input", debounce((event) => {
        const url = event && (event as any).target.value;

        if (!url) {
            setPreviewImage(null, "");
            return;
        }

        const onSuccess = (urlIsImage: boolean) => {
            if (urlIsImage) {
                setPreviewImage((event as any).srcElement.value);
            } else {
                setPreviewImage(null, "The provided URL does not represent an image.");
            }
        };
        const onError = (errorMessage: string) => {
            setPreviewImage(null, errorMessage);
        };

        isUrlImage(url).then(onSuccess, onError);
    }, 500));
}

window.Company = {
    ...window.Company,
    formComponents: {
        imageUrlWithPreview: {
            init,
        }
    },
    debounce,
    isUrlImage,
};