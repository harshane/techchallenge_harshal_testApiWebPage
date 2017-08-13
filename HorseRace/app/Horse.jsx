var Horse = React.createClass({
    render: function() {
        return (
          <tr>
            <td> Name :-            {this.props.Name} </td>
            <td> Number of Bets :   {this.props.NumberOfBets} </td>
            <td> Winning Amount :-   {this.props.WinningAmount.toString()} </td>
          </tr>
      );
    }
});