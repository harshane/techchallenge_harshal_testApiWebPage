var Race = React.createClass({
    render: function() {
        return (
          <tr>
            <td> {this.props.Name} </td>
            <td> {this.props.TotalBetAmount} </td>
            <td> {this.props.RaceFinished ? "Finished" : "Pending"} </td>
            <td> <HorseList data={this.props.Horses} /> </td>
          </tr>
      );
    }
});