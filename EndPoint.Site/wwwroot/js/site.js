////$(document).ready(function () {

////    kamaDatepicker('cleander', {
////        buttonsColor: "red",
////        forceFarsiDigits: true,
////        markToday: true,
////        markHolidays: true,
////        gotoToday: true,
////        nextButtonIcon:"bi-caret-right-fill",
////        previousButtonIcon:"bi-caret-left-fill"
////    });

////})

function SetDateInput() {
    kamaDatepicker('cleander', {
        buttonsColor: "red",
        forceFarsiDigits: true,
        markToday: true,
        markHolidays: true,
        gotoToday: true,
        nextButtonIcon: "bi-caret-right-fill",
        previousButtonIcon: "bi-caret-left-fill"
    });
}

function StartLoading(element = 'body') {
    $(element).waitMe({
        effect: 'bounce',
        text: 'Please Wait ...',
        bg: 'rgba(255, 255, 255, 0.7)',
        color: '#000'
    });
}

function CloseLoading(element = 'body') {
    $(element).waitMe('hide');
}

function LoadCreatePageModal() {
    $.ajax({
        url: "/Admin2/Home2/LoadCreatePageModal",
        type: "get",
        beforeSend: function () {
            StartLoading();

        },
        success: function (response) {
            CloseLoading();
            $("#ModalContentBody").html(response);


            $('#CreatePageForm').data('validator', null);
            $.validator.unobtrusive.parse('#CreatePageForm');

            $("#MyModal").modal("show");

            SetDateInput();
        },
        error: function () {
            CloseLoading();
            swal("Error", "Some thing went wrong please try again ...", "error");
        }
    });
}

function LoadEditePageModal(PageId) {
    $.ajax({
        url: "/Admin2/Home2/LoadEditePageModal",
        type: "get",
        data: {
            PageId: PageId
        },
        beforeSend: function () {
            StartLoading();

        },
        success: function (response) {
            CloseLoading();
            $("#ModalContentBody").html(response);


            $('#CreatePageForm').data('validator', null);
            $.validator.unobtrusive.parse('#CreatePageForm');

            $("#MyModal").modal("show");

            SetDateInput();
        },
        error: function () {
            CloseLoading();
            swal("Error", "Some thing went wrong please try again ...", "error");
        }
    });
}


function CreatePageFormSubmited(response) {
    
    if (response.status === "Success") {
        swal("Done", "The Operation Has Done Successfully", "success");
        $("#MyModal").modal("hide");
        $("#MainDiv").load(location.href + " #MainDiv");
    } else {
        swal("Error", "Some thing went wrong please try again ...", "error");
    }
    CloseLoading();
}


function DeletePage(PageId) {
    swal({
        title: "Are you sure ?",
        text: "Once deleted, you will not be able to recover this imaginary file !",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {
                $.ajax({
                    url: "/Admin2/Home2/DeletePage",
                    type: "Post",
                    data: {
                        PageId: PageId
                    },
                    beforeSend: function () {
                        StartLoading();
                    },
                    success: function (response) {
                        CloseLoading();
                        if (response.status === "Success") {
                            swal("Done", "The Operation Has Done Successfully", "success");
                            $('#Page-' + PageId).fadeOut();
                        } else {
                            swal("Error", "Some thing went wrong please try again ...", "error");
                        }
                    },
                    error: function () {
                        CloseLoading();
                        swal("Error", "Some thing went wrong please try again ...", "error");
                    }
                });
            }
        });
}
