var seconds = 0;

        // called when the page loads to begin the timer
        function startTimer() {
            // 1000 milliseconds = 1 second
            window.setInterval("updateTime()", 1000);
        } // end function startTimer

        // called every 1000 ms to update the timer
        function updateTime() {
            ++seconds;
            document.getElementById("soFar").innerHTML = seconds;
        }