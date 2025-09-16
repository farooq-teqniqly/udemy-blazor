window.ShowToastr = (type, message) => {
    if (type == "success") {
        toastr.success(message);
        return;
    }

    if (type == "error") {
        toastr.error(message);
        return;
    }
} 