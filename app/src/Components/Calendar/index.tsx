import React from "react";
import Chrono from "../../Utils/chrono";

import "./styles.css";

interface CalendarProps {
  today?: Date;
};

class Calendar extends React.Component<CalendarProps> {
  private _cal = new Chrono();

  private get monthCalendar(): Array<Array<number>> {
    const today = this.props.today || new Date();
    return this._cal.getYearCalendar()[today.getMonth()];
  }

  renderHeaderRow(): JSX.Element {
    return (
      <div className="calendar-header">
        {Chrono.daysOfWeek.map(day => <div className="calendar-header-cell">{day.slice(0, 3)}</div>)}
      </div>
    );
  }

  private renderCalendarRows(): JSX.Element[] {
    const CalenderRows = [];

    console.log(this.monthCalendar);

    for (let rowIdx = 0; rowIdx < 5; rowIdx++) {
      const CalenderCols = [<div></div>];
      for (let colIdx = 0; colIdx < 7; colIdx++) {
        const day = this.monthCalendar[rowIdx][colIdx];
        CalenderCols.push(
          <div className="calendar-cell" key={`${rowIdx}-${colIdx}`}>
            {day === 0 ? "" : day}
          </div>
         );
      }

      CalenderRows.push(
        <div key={rowIdx} className="calendar-row">
          {CalenderCols}
        </div>
      );
    }
    return CalenderRows;
  }

  render(): JSX.Element {
    return (
      <div className="calendar">
        {this.renderHeaderRow()}
        {this.renderCalendarRows()}
      </div>
    );
  }
}

export default Calendar;