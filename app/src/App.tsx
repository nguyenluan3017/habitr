import React, { useCallback, useEffect } from 'react';
import Calendar from './Components/Calendar/index';
import Chrono from "./Utils/chrono";

function App(): JSX.Element {
  useEffect(() => {
    document.title = "Calendar App";
  });

  const [date, setDate] = React.useState(new Date());

  const navigateTo = useCallback((direction: "last-month" | "next-month" | "today") => () => {
    switch (direction) {
      case "last-month":
        setDate(new Date(date.getFullYear(), date.getMonth() - 1, 1));
        break;
      case "next-month":
        setDate(new Date(date.getFullYear(), date.getMonth() + 1, 1));
        break;
      case "today":
        setDate(new Date());
    }
  }, [date]);

  console.log(date)

  return (
    <div className="calendar">
      <div className="calendar-toolbar">
        <h1>{Chrono.monthsOfYear[date.getMonth()]} {date.getFullYear()}</h1>
        <div>
          <button className="calendar-toolbar-button" onClick={navigateTo("last-month")}>{"< Back"}</button>
          <button className="calendar-toolbar-button" onClick={navigateTo("today")}>Today</button>
          <button className="calendar-toolbar-button" onClick={navigateTo("next-month")}>{"Next >"}</button>
        </div>
      </div>
      {<Calendar today={date} />}
    </div>
  );
}

export default App;
