class Chrono {
    public today = new Date();

    public static daysOfWeek: Array<string> = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    public static monthsOfYear: Array<string> = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

    public yearCalendar: { [key: number]: Array<Array<number>> } | null = null;

    public isLeapYear(): boolean {
        const fullYear = this.today.getFullYear();
        if (fullYear % 4 !== 0) {
            return false;
        } else if (fullYear % 100 !== 0) {
            return true;
        } else if (fullYear % 400 !== 0) {
            return false;
        } else {
            return true;
        }
    }

    public getYearCalendar(): { [key: number]: Array<Array<number>> } {
        if (this.yearCalendar == null) {
            this.yearCalendar = {};

            for (let month = 0; month < 12; month++) {
                const firstDayOfMonth = new Date(this.today.getFullYear(), month, 1);
                const lastDayOfMonth = new Date(this.today.getFullYear(), month + 1, 0);
                const firstDayIndex = firstDayOfMonth.getDay();
                const monthCalendar: number[][] = [[]];

                for (let day = -firstDayIndex + 1; day <= lastDayOfMonth.getDate(); day++) {
                    const week = monthCalendar[monthCalendar.length - 1];
                    week.push(day < 1 ? 0 : day);
                    if (week.length == 7) {
                        monthCalendar.push([]);
                    }
                }

                while (monthCalendar[monthCalendar.length - 1].length < 7) {
                    monthCalendar[monthCalendar.length - 1].push(0);
                }

                this.yearCalendar[month] = monthCalendar;
            }
        }

        return this.yearCalendar;
    }
}

export default Chrono;