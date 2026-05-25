let currentLoginStep = 1;
const totalLoginSteps = 2;

function validateCurrentLoginStep() {
    const form = $("form");
    const step = $("#step" + currentLoginStep);

    let valid = true;

    step.find("input, select, textarea").each(function () {
        if (!form.validate().element(this)) {
            valid = false;
        }
    });

    return valid;
}

function nextStep() {
    if (!validateCurrentLoginStep()) {
        return;
    }

    if (currentLoginStep < totalLoginSteps) {
        currentLoginStep++;
        showLoginStep();
    }
}

function showLoginStep() {
    $(".step").removeClass("active");

    $("#step" + currentLoginStep).addClass("active");

    if (currentLoginStep === totalLoginSteps) {
        $("#nextBtn").hide();
        $("#submitBtn").show();
    } else {
        $("#nextBtn").show();
        $("#submitBtn").hide();
    }
}

$(document).ready(function () {
    showLoginStep();

    $("form").on("submit", function (e) {
        if (!validateCurrentLoginStep()) {
            e.preventDefault();
            return false;
        }
    });
});