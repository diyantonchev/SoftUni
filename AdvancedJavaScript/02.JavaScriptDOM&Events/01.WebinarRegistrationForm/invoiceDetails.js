function toggleInvoiceDetails(invoiceCheckBox) {
    "use strict";

    var isChecked, invoiceDetails;
    isChecked = invoiceCheckBox.checked;
    invoiceDetails = document.getElementById('invoice-details');
    if (isChecked) {
        invoiceDetails.style.visibility = 'visible';
    } else {
        invoiceDetails.style.visibility = 'hidden';
    }
}

var invoiceCheckBox = document.getElementById('invoice');
toggleInvoiceDetails(invoiceCheckBox);